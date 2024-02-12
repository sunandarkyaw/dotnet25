-- Table to store templates
CREATE TABLE Templates (
    template_id INT PRIMARY KEY AUTO_INCREMENT,
    template_name VARCHAR(255) NOT NULL
);

-- Table to store fields for each template
CREATE TABLE Fields (
    field_id INT PRIMARY KEY AUTO_INCREMENT,
    template_id INT,
    field_name VARCHAR(255) NOT NULL,
    field_type VARCHAR(50) NOT NULL, -- Dropdown, Input Text, Checkbox, Radio Box
    field_options TEXT, -- JSON array for Dropdown and Radio Box type
    FOREIGN KEY (template_id) REFERENCES Templates(template_id)
);

-- Table to store submissions
CREATE TABLE Submissions (
    submission_id INT PRIMARY KEY AUTO_INCREMENT,
    template_id INT,
    submitted_by VARCHAR(255) NOT NULL, -- Visitor's name or identifier
    submission_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (template_id) REFERENCES Templates(template_id)
);

-- Table to store field values for each submission
CREATE TABLE FieldValues (
    submission_id INT,
    field_id INT,
    field_value TEXT,
    PRIMARY KEY (submission_id, field_id),
    FOREIGN KEY (submission_id) REFERENCES Submissions(submission_id),
    FOREIGN KEY (field_id) REFERENCES Fields(field_id)
);
