
CREATE TABLE customers (
    Id SERIAL PRIMARY KEY,
    FirstName VARCHAR(255) NOT NULL,
    LastName VARCHAR(255) NOT NULL,
    Address VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    Phone BIGINT,
    Active BOOLEAN NOT NULL DEFAULT true
);

INSERT INTO customers (FirstName, LastName, Address, Email, Phone, Active) VALUES
    ('John', 'Doe', '123 Main St', 'john.doe@example.com', 1234567890, true),
    ('Jane', 'Smith', '456 Elm St', 'jane.smith@example.com', 9876543210, false),
    ('Alice', 'Johnson', '789 Maple Ave', 'alice.johnson@example.com', 5551234567, true),
    ('Bob', 'Brown', '321 Oak St', 'bob.brown@example.com', 5559876543, true),
    ('Charlie', 'Davis', '654 Pine St', 'charlie.davis@example.com', 5555678901, false),
    ('Emily', 'Wilson', '987 Birch Ave', 'emily.wilson@example.com', 5556789012, true),
    ('Frank', 'Miller', '159 Cedar St', 'frank.miller@example.com', 5557890123, true),
    ('Grace', 'Lee', '753 Spruce St', 'grace.lee@example.com', 5558901234, false),
    ('Henry', 'Clark', '852 Willow St', 'henry.clark@example.com', 5559012345, true),
    ('Isabella', 'White', '456 Aspen St', 'isabella.white@example.com', 5550123456, true);
