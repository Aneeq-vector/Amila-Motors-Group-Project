use amilamotors
CREATE TABLE appointment_table (
    appointmentID varchar(50) NULL,
    bookingDate date NULL,
    appointmentDate date NULL,
    reason varchar(50) NULL,
    createdBy varchar(50) NULL,
    customerID varchar(50) NULL,
    vehicleID varchar(50) NULL
);

CREATE TABLE administrator_table (
    adminID varchar(50) NULL,
    adminlevel varchar(50) NULL
);

CREATE TABLE assignedtask_table (
    Tno varchar(50) NULL,
    LaborID varchar(50) NULL,
    jobID varchar(50) NULL,
    Status varchar(50) NULL
);

CREATE TABLE attendance_table (
    attendanceID varchar(50) NULL,
    checkIN datetime NULL,
    CheckOut datetime NULL,
    Date date NULL,
    WorkingHours int NULL,
    LaborID varchar(50) NULL
);

CREATE TABLE backup_table (
    backupID varchar(50) NULL,
    path varchar(50) NULL,
    backupdate date NULL,
    userID varchar(50) NULL
);

CREATE TABLE customer_table (
    customerID varchar(50) NULL,
    customerName varchar(50) NULL,
    customerNIC varchar(50) NULL,
    customerContact varchar(50) NULL,
    userID varchar(50) NULL,
    status varchar(50) NULL
);

CREATE TABLE customercare_assistant_table (
    customerCAID varchar(50) NULL,
    experience varchar(50) NULL,
    qualification varchar(50) NULL
);

CREATE TABLE GRN_table (
    grnID varchar(50) NULL,
    grndate date NULL,
    totalAmount float NULL,
    quantityRecieved int NULL,
    grnStatus varchar(50) NULL,
    supplierID varchar(50) NULL,
    createdBy varchar(50) NULL,
    itemID varchar(50) NULL
);

CREATE TABLE income_table (
    invoiceID varchar(50) NULL,
    invoiceNo varchar(50) NULL,
    amount float NULL,
    invoiceDate date NULL,
    status varchar(50) NULL,
    jobID varchar(50) NULL,
    customerID varchar(50) NULL,
    createdBy varchar(50) NULL
);

CREATE TABLE item_table (
    itemID varchar(50) NULL,
    itemname varchar(50) NULL,
    itemBrand varchar(50) NULL,
    cost float NULL,
    sellingPrice float NULL,
    quantity int NULL,
    markupRate float NULL
);

CREATE TABLE itemsupplier_table (
    ItemSupplierID varchar(50) NULL,
    itemID varchar(50) NULL,
    supplierID varchar(50) NULL
);

CREATE TABLE job_table (
    jobID varchar(50) NULL,
    jobstatus varchar(50) NULL,
    assignedDate date NULL,
    startdate date NULL,
    enddate date NULL,
    appointmentID varchar(50) NULL,
    customerID varchar(50) NULL,
    vehicleID varchar(50) NULL,
    laborID varchar(50) NULL,
    createdBy varchar(50) NULL
);

CREATE TABLE jobcoordinator_table (
    jobcoordinatorID varchar(50) NULL,
    experience varchar(50) NULL,
    qualification varchar(50) NULL
);

CREATE TABLE JobCosting_table (
    jcID varchar(50) NULL,
    jcDate date NULL,
    laborCost float NULL,
    sparePartCost float NULL,
    serviceCost float NULL,
    total float NULL,
    createdBy varchar(50) NULL
)

CREATE TABLE labor_table (
    laborID varchar(50) NULL,
    skilllevel varchar(50) NULL,
    hourlyrate float NULL
)

CREATE TABLE laborcosting_table (
    sNo varchar(50) NULL,
    workinghours int NULL,
    total float NULL,
    laborID varchar(50) NULL,
    jcID varchar(50) NULL
)

CREATE TABLE manager_table (
    managerID varchar(50) NULL,
    qualification varchar(50) NULL,
    managerlevel varchar(50) NULL
)

CREATE TABLE payment_table (
    paymentID varchar(50) NULL,
    amount float NULL,
    paymentdate date NULL,
    status varchar(50) NULL,
    GRNID varchar(50) NULL,
    supplierId varchar(50) NULL
)

CREATE TABLE sparepartcosting_table (
    sNo varchar(50) NULL,
    quantity int NULL,
    total float NULL,
    itemID varchar(50) NULL,
    jcID varchar(50) NULL
)

CREATE TABLE supplier_table (
    supplierID varchar(50) NULL,
    companyName varchar(50) NULL,
    address varchar(50) NULL,
    contact varchar(50) NULL,
    status varchar(50) NULL,
    email varchar(50) NULL
)

CREATE TABLE user_table (
    userID varchar(50) NULL,
    userfullname varchar(50) NULL,
    username varchar(50) NULL,
    password varchar(50) NULL,
    contact varchar(50) NULL,
    dateofjoin date NULL,
    email varchar(50) NULL,
    role varchar(50) NULL
)

CREATE TABLE vehicle_table (
    vehicleID varchar(50) NULL,
    vehicleno varchar(50) NULL,
    type varchar(50) NULL,
    model varchar(50) NULL,
    vehicleyom date NULL
)

