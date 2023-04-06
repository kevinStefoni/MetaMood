function SortingButtons(id) {

    var wasActive = document.getElementById(id).classList.contains('table-head-button-active');
    var otherActiveButtons = document.getElementsByClassName('table-head-button-active');

    for (var i = 0; i < otherActiveButtons.length; i++) {
        otherActiveButtons[i].classList.add('table-head-button');
        otherActiveButtons[i].classList.remove('table-head-button-active');
    }

    if (wasActive) {
        document.getElementById(id).classList.add('table-head-button');
        document.getElementById(id).classList.remove('table-head-button-active');
        return 1;
    }
    else {
        document.getElementById(id).classList.add('table-head-button-active');
        document.getElementById(id).classList.remove('table-head-button');
        return 0;
    }

}


