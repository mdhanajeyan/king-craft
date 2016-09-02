//# sourceURL=jquery-extension-import-js.js
(function ($) {
    var importJsImported = [];
    $.extend(true, {

        import_js: function (script) {

            var found = false;
            for (var i = 0; i < importJsImported.length; i++) {
                if (importJsImported[i] === script) {
                    found = true;
                    break;
                }
            }

            if (!found) {
                $("head").append('<script src="' + script + '"></script>');
                importJsImported.push(script);
            }
        }
    });

})(jQuery);
//# sourceURL=jquery-extension-import-js.js