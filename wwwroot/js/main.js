const connection = new signalR.HubConnectionBuilder().withUrl('/RandomHub').build();

const $randomNumber = document.getElementById('random-number');
const $updateButton = document.getElementById('update-button');

$updateButton.addEventListener('click', () => {
    connection.invoke('GenerateNumber', {max: 1000});
});

connection.on('ReceiveNumber', ({number}) => {
    $randomNumber.innerHTML = number;
});

connection.start();
