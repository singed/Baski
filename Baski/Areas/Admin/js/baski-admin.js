$(function () {
    tinymce.init({
        selector: 'textarea',
        plugins: "table preview "
    });

    $('input[id="Date"]').datepicker({ dateFormat: 'dd.mm.yy' });
});
