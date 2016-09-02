//# sourceURL=jquery-extension-import-css.js
(function ($) {
    var importCssImported = [];
    $.extend(true, {

        import_css: function (script) {

            var found = false;
            for (var i = 0; i < importCssImported.length; i++) {
                if (importCssImported[i] === script) {
                    found = true;
                    break;
                }
            }

            if (!found) {
                $("head").append('<link rel="stylesheet" href="' + script + '">');
                importCssImported.push(script);
            }
        }
    });

})(jQuery);
//# sourceURL=jquery-extension-import-css.js