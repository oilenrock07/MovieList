$(function () {

    function handleGetDetailsOnClick() {

        var imdbId = $('#Search').val();
        if (imdbId == '') {
            alert('Please enter IMDB ID on the search box');
            return;
        }

        $.ajax({
            url: '/Maintenance/GetHtmlString',
            data: { imdbId: imdbId },
            type: 'POST',
            success: handleGetDetailsSuccess
        });
    };

    function handleGetDetailsSuccess(responseData) {
        var response = $(responseData);

        $('.js-title').val(response.find('.title_wrapper h1').text());
        $('.js-year').val(response.find('#titleYear a').text());
        $('.js-rate').val(response.find('.ratings_wrapper').find('[itemprop="ratingValue"]').html());
        $('.js-rating').val(response.find('.titleBar').find('meta[itemprop="contentRating"]').attr("content"));
        $('.js-runtime').val(response.find('.title_bar_wrapper time[itemprop="duration"]').text().trim());
        $('.js-country').val(response.find('#titleDetails .txt-block:contains("Country") a').text());
        $('.js-language').val(response.find('#titleDetails .txt-block:contains("Language") a').text());
        $('.js-releasedDate').val(response.find('.title_wrapper [itemprop="datePublished"]').attr('content'));
        $('.js-imdbId').val($('#Search').val());

        $('.js-photos').val(response.find('.mediastrip_container a:contains("photos")').attr('href'));
        $('.js-poster').val(response.find('.poster img').attr('src'));
        $('.js-metaScore').val(response.find('.metacriticScore span').html());
        $('.js-reviewLink').val(response.find('.titleReviewBarItem a:contains("user")').attr('href'));
        $('.js-awards').val(response.find('#titleAwardsRanks .see-more a').attr('href'));

        $('.js-budget').val(response.find('#titleDetails h4:contains("Budget")').parent().text().trim());
        $('.js-gross').val(response.find('#titleDetails h4:contains("Gross")').parent().text().trim());
        $('.js-summary').val(response.find('.summary_text').html().trim());
        $('.js-storyline').val(response.find('#titleStoryLine p').parent().text().trim());

        var genre = splitString(response.find('.titleBar').find('span.itemprop'));
        $('.js-genre').val(genre);

        var stars = splitString(response.find('.cast_list td.itemprop a'));
        $('.js-stars').val(stars);

        var writers = splitString(response.find('.credit_summary_item').find('[itemprop="creator"] a'));
        $('.js-writers').val(writers);
    }

    function splitString(selector) {
        var item = '';
        $(selector).each(function (i, value) {
            item += $(value).text().trim() + ' | ';
        });

        return item;
    }

    function init() {
        $('.js-getImdbDetails').on('click', handleGetDetailsOnClick);
    };

    init();
});