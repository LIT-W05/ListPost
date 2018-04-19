$(function () {
    $(".edit").on('click', function () {
        var personId = $(this).data('person-id');
        var row = $(this).closest('tr');
        var firstName = row.find('td:eq(0)').text();
        var lastName = row.find('td:eq(1)').text();
        var age = row.find('td:eq(2)').text();

        $("#person-id-hidden").val(personId);
        $("#firstName").val(firstName);
        $("#lastName").val(lastName);
        $("#age").val(age);

        $("#edit-modal").modal();
    });
})