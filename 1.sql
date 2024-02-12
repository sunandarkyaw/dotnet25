-- Table to store Buildings
CREATE TABLE Buildings (
    building_id INT PRIMARY KEY,
    building_name VARCHAR(50) NOT NULL
);

-- Table to store Levels
CREATE TABLE Levels (
    level_id INT PRIMARY KEY,
    level_name varchar(50) NOT NULL,
    building_id INT,
    FOREIGN KEY (building_id) REFERENCES Buildings(building_id)
);

-- Table to store Rooms
CREATE TABLE Rooms (
    room_id INT PRIMARY KEY,
    room_name VARCHAR(20) NOT NULL,
    level_id INT,
    FOREIGN KEY (level_id) REFERENCES Levels(level_id)
);

-- Table to store Other Locations (e.g., Carpark, Pantry, Lobby, etc.)
CREATE TABLE OtherLocations (
    location_id INT PRIMARY KEY,
    location_name VARCHAR(50) NOT NULL,
    parent_location_id INT, -- To store the parent location of this location
    FOREIGN KEY (parent_location_id) REFERENCES OtherLocations(location_id)
);