console.log("Welcome to the Community Portal");

window.onload = function () {
    alert("Community Portal Fully Loaded");
};

const eventName = "Music Festival";
const eventDate = "2026-08-15";
let seats = 5;

console.log(`Event: ${eventName}, Date: ${eventDate}, Seats: ${seats}`);

class Event {
    constructor(name, date, category, location, seats) {
        this.name = name;
        this.date = date;
        this.category = category;
        this.location = location;
        this.seats = seats;
    }
}

Event.prototype.checkAvailability = function () {
    return this.seats > 0;
};

let events = [];

function addEvent(event) {
    events.push(event);
}

addEvent(new Event(
    "Music Festival",
    "2026-08-15",
    "Music",
    "City Park",
    5
));

addEvent(new Event(
    "Baking Workshop",
    "2026-09-10",
    "Workshop",
    "Community Hall",
    3
));

addEvent(new Event(
    "Football Tournament",
    "2026-07-25",
    "Sports",
    "City Stadium",
    4
));

addEvent(new Event(
    "Past Cultural Event",
    "2025-01-10",
    "Music",
    "Town Hall",
    5
));

Object.entries(events[0]).forEach(function ([key, value]) {
    console.log(key, value);
});

const musicEvents = events.filter(function (event) {
    return event.category === "Music";
});

console.log("Music Events:", musicEvents);

const eventNames = events.map(function (event) {
    return `Event: ${event.name}`;
});

console.log(eventNames);

function registrationCounter() {
    let total = 0;

    return function () {
        total++;
        return total;
    };
}

const musicRegistration = registrationCounter();

function registerUser(event) {
    try {
        if (!event) {
            throw new Error("Event not found");
        }

        if (!event.checkAvailability()) {
            throw new Error("No seats available");
        }

        event.seats--;
        seats--;

        console.log("Total Registration:", musicRegistration());

        displayEvents(events);

    } catch (error) {
        alert(error.message);
    }
}

function cancelRegistration(event) {
    event.seats++;
    displayEvents(events);
}

function filterEventsByCategory(category, callback) {
    const copy = [...events];

    const result = category === "All"
        ? copy
        : copy.filter(callback);

    displayEvents(result);
}

const container = document.querySelector("#eventContainer");

function displayEvents(eventList = events) {
    container.innerHTML = "";

    eventList.forEach(function (event) {

        const today = new Date();
        const eventDay = new Date(event.date);

        if (eventDay < today || event.seats <= 0) {
            return;
        }

        const card = document.createElement("div");
        card.className = "event-card";

        const { name, date, category, location, seats } = event;

        card.innerHTML = `
            <h3>${name}</h3>
            <p>Date: ${date}</p>
            <p>Category: ${category}</p>
            <p>Location: ${location}</p>
            <p>Available Seats: ${seats}</p>
        `;

        const registerButton = document.createElement("button");
        registerButton.innerText = "Register";

        registerButton.onclick = function () {
            registerUser(event);
        };

        const cancelButton = document.createElement("button");
        cancelButton.innerText = "Cancel";

        cancelButton.onclick = function () {
            cancelRegistration(event);
        };

        card.appendChild(registerButton);
        card.appendChild(cancelButton);

        container.appendChild(card);
    });
}

function filterCategory() {
    const category =
        document.querySelector("#categoryFilter").value;

    filterEventsByCategory(
        category,
        event => event.category === category
    );
}

function searchEvent() {
    setTimeout(function () {

        const text =
            document.querySelector("#search")
            .value
            .toLowerCase();

        const result = events.filter(function (event) {
            return event.name.toLowerCase().includes(text);
        });

        displayEvents(result);

    }, 100);
}

function fetchEventsPromise() {

    fetch("https://jsonplaceholder.typicode.com/posts?_limit=3")
        .then(response => response.json())
        .then(data => {
            console.log("Promise Data:", data);
        })
        .catch(error => {
            console.log("Fetch Error:", error);
        });
}

fetchEventsPromise();

async function fetchEvents() {

    const spinner = document.querySelector("#spinner");

    spinner.style.display = "block";

    try {

        const response = await fetch(
            "https://jsonplaceholder.typicode.com/posts?_limit=3"
        );

        const data = await response.json();

        console.log("Async Data:", data);

    } catch (error) {

        console.log(error);

    } finally {

        spinner.style.display = "none";

    }
}

fetchEvents();

const form = document.querySelector("#registrationForm");

form.addEventListener("submit", function (event) {

    event.preventDefault();

    console.log("Form submission started");

    const name = form.elements.username.value;
    const email = form.elements.email.value;
    const selectedEvent = form.elements.event.value;

    document.querySelector("#nameError").innerText = "";
    document.querySelector("#emailError").innerText = "";
    document.querySelector("#eventError").innerText = "";

    let valid = true;

    if (name === "") {
        document.querySelector("#nameError").innerText =
            "Name is required";

        valid = false;
    }

    if (email === "") {
        document.querySelector("#emailError").innerText =
            "Email is required";

        valid = false;
    }

    if (selectedEvent === "") {
        document.querySelector("#eventError").innerText =
            "Please select an event";

        valid = false;
    }

    if (!valid) {
        return;
    }

    const userData = {
        name,
        email,
        event: selectedEvent
    };

    console.log("Fetch Payload:", userData);

    setTimeout(function () {

        fetch(
            "https://jsonplaceholder.typicode.com/posts",
            {
                method: "POST",
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify(userData)
            }
        )
        .then(response => response.json())
        .then(data => {

            console.log("Server Response:", data);

            document.querySelector("#message").innerText =
                "Registration Successful";

        })
        .catch(error => {

            console.log("Registration Error:", error);

            document.querySelector("#message").innerText =
                "Registration Failed";

        });

    }, 1000);
});

$("#registerBtn").click(function () {
    console.log("Register button clicked using jQuery");
});

$(".event-card").fadeOut(300).fadeIn(500);

displayEvents(events);