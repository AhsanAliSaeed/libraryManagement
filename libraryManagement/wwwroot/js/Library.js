$(document).ready(function () {
    GetBooks();
    $('#BkID').change(function () {
        var id = $(this).val();
        $('#Author').empty();
        $('#Author').append('<Option>--Select Author--</Option>');
        $.ajax({
            url: '/Library/Author?id=' + id,
            success: function (result) {
                $.each(result, function (i, data) {
                    $('#Author').append('<Option Value=' + data.authorID + '>' + data.authorName + '</Option>');
                });
            }
        });
    });

});
function GetBooks() {
    $.ajax({
        url: '/Library/Book',
        success: function (result) {
            $.each(result, function (i, data) {
                $('#BkID').append('<Option value=' + data.bookID + '>' + data.bookName + '</Option>');
            });
        }
    });
}