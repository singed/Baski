(function() {
    $('.load-more').click(function () {
        var elm = this;
        var url = $(this).attr('data-more-articles-url');
        $.get(url).then(function(data) {
            $(elm).replaceWith(data);
            jQuery("body").fitVids();
        });
    });

})();