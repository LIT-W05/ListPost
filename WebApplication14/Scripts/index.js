$(function() {
    let number = 1;
    $("#add-row").on('click', function () {
        const firstNameTextBox = getInput(`people[${number}].firstName`, "First Name");
        const lastNameTextBox = getInput(`people[${number}].lastName`, "Last Name");
        const ageTextBox = getInput(`people[${number}].age`, "Age");
        $("table").append(`<tr><td>${firstNameTextBox}</td><td>${lastNameTextBox}</td><td>
            ${ageTextBox}</td></tr>`);
        number++;
    });

    function getInput(name, placeholder) {
        return `<input type='text' placeholder='${placeholder}' name='${name}' class='form-control' />`;
    }
});