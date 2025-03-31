document.getElementById('registration-form').addEventListener('submit', function (event) {
    event.preventDefault(); // Forhindre standard formularindsendelse

    // Hent værdier fra formularen
    const username = document.getElementById('username').value;
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;
    const confirmPassword = document.getElementById('confirm-password').value;

    // Tjek om adgangskoderne matcher
    if (password !== confirmPassword) {
        document.getElementById('message').innerText = "Adgangskoderne matcher ikke.";
        return;
    }

    // Opret en brugerobjekt
    const user = {
        username: username,
        email: email,
        password: password
    };

    // Send brugerobjektet til API'et
    fetch('/api/account/register', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    })
        .then(response => {
            if (response.ok) {
                return response.json();
            }
            throw new Error('Netværksrespons var ikke ok.');
        })
        .then(data => {
            document.getElementById('message').innerText = "Konto oprettet! Du kan nu logge ind.";
            document.getElementById('registration-form').reset();
        })
        .catch(error => {
            console.error('Der opstod en fejl:', error);
            document.getElementById('message').innerText = "Fejl ved oprettelse af konto.";
        });
});