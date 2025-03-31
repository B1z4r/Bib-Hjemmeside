document.getElementById('login-form').addEventListener('submit', function (event) {
    event.preventDefault(); // Forhindre standard formularindsendelse

    // Hent værdier fra formularen
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;

    // Opret en loginobjekt
    const loginData = {
        email: email,
        password: password
    };

    // Send loginobjektet til API'et
    fetch('/api/account/login', {
        method: 'POST', // Sørg for, at metoden er POST
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(loginData)
    })
        .then(response => {
            if (response.ok) {
                return response.json();
            }
            throw new Error('Netværksrespons var ikke ok.');
        })
        .then(data => {
            console.log(data.message); // Log indsuccess
        })
        .catch(error => {
            console.error('Der opstod en fejl:', error);
        });
});