var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('tigerball');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);