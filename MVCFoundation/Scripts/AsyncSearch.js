$(function (){
    var table = $("table[data-table-area]");
    var searchbutton = $("button[data-search-button]")
        .click(onSearchAsyncClick);
    var searchfield = $("input[data-search-field");

    function onSearchAsyncClick() {
        // Get the action url to call on the server
        var url = table.attr("data-table-action-url");

        // Get the value from the search textbox
        var value = searchfield.val();

        // Only call the server if there is a url present on the table
        if (url != "") {
            // Make an async call to the server passing in
            // the value from the textbox as the search term
            $.post(url, { searchTerm: value }, function (data) {
                // update the partial view with the result
                table.html(data);
            }).fail(function (xhr, status, error) {
                //handle errors
                alert("Error");
            });
        }

    }

});