const connection = new signalR.HubConnectionBuilder().withUrl('/RandomHub').build();

const $randomNumber = document.getElementById('random-number');
const $updateButton = document.getElementById('update-button');

$updateButton.addEventListener('click', () => {
    connection.invoke('GenerateNumber');
});

connection.on('ReceiveNumber', (random) => {
    $randomNumber.innerHTML = random;
});

connection.start();
