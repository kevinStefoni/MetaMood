window.jsFunctions =
{
    TimedWelcome: function () {
        var today = new Date();
        var hourNow = today.getHours();

        var greeting;
        if (hourNow >= 21 || hourNow <= 3)
        {
            greeting = 'Good night!';
        }
        else if(hourNow >= 18) {
            greeting = 'Good evening!';
        }
        else if (hourNow >= 12) {
            greeting = 'Good afternoon!';
        }
        else if (hourNow > 3) {
            greeting = 'Good morning!';
        }
        else {
            greeting = 'Welcome!';
        }

        document.getElementById('greeting').innerHTML = greeting;
    }
}

