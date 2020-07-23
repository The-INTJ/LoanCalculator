// Form to react to textbox data change on loan calculator form

// Text box 1
if ($("#reactive-1").val() == 0) {
    $("#modify > input").prop("value", "");
}

function CheckClear(content)
{
    $("#reactive-1").on("keyup", function() {
        if ($("#reactive-1").val() != content) {
            console.log($("#reactive-1").val());
            $("#modify > input").prop("value", "");
        }
    })
}

$("#reactive-1").on("focus", function () {
    var content = $("#reactive-1").val();
    console.log(content);
    CheckClear(content);
})

// Text box 2
if ($("#reactive-2").val() == 0) {
    $("#modify > input").prop("value", "");
}

function CheckClear2(content) {
    $("#reactive-2").on("keyup", function () {
        if ($("#reactive-2").val() != content) {
            console.log($("#reactive-2").val());
            $("#modify > input").prop("value", "");
        }
    })
}

$("#reactive-2").on("focus", function () {
    var content = $("#reactive-2").val();
    console.log(content);
    CheckClear2(content);
})
