var App = App || {};
(function () {

    var appLocalizationSource = abp.localization.getSource('SalesManagementSystem');
    App.localize = function () {
        return appLocalizationSource.apply(this, arguments);
    };

})(App);