


//---------------------------------------------------------------------------
// UFO [Query 1] Calls

// Function to populate UFO state dropdown menu
$(function () {
    $.ajax({
        type: "GET",
        url: 'api/ufo/state',
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            $.each(r, function (key, state) {
                $('#ufoState').append($('<option></option>').val(state.$id).html(state.State));
            });
        }
    });
});

function GetUFOs() {
    
}


//---------------------------------------------------------------------------
// Meteorite [Query 2] Calls

// Function to populate Meteorite classification dropdown menu
$(function () {
    $.ajax({
        type: "GET",
        url: 'api/meteorite/classification',
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            $.each(r, function (key, meteorite) {
                $('#metClassification').append($('<option></option>').val(meteorite.$id).html(meteorite.Classification));
            });
        }
    });
});

function GetMeteorites() {

}


//---------------------------------------------------------------------------
// Year [Query 3] Calls

// Function to popoulate Year dropdown menu
$(function () {
    $.ajax({
        type: "GET",
        url: 'api/year/year',
        data: '{}',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            $.each(r, function (key, year) {
                $('#yearSelect').append($('<option></option>').val(year.$id).html(year.Year1));
            });
        }
    });
});

function GetYearComparison() {

    var select = document.querySelector("#yearSelect");
    var id = select.options[select.selectedIndex].text;
    console.log(id);

    $(function () {
        $.ajax({
            type: "GET",
            url: 'api/Year/year?id=' + id,
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (year) {
                console.log(year)
                //StoreSalesListSuccess(year)
            }
        });
    });
}
