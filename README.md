# CSIS1175-GroceryManagementSystem
This application, written in C# and designed as a Windows Form application, serves as a Grocery Management System. Its main purpose is to manage a grocery store's inventory, allowing for efficient tracking of items, their quantities, sales, and restocking needs.

Each item in the inventory is represented by an instance of the Grocery class.

Features of the application include:

Loading data from a .csv file containing grocery items.

Displaying the items in a ListBox control.

Allowing the user to select an item from the list and display its details.

Updating the quantity sold and restocked for an item.

Deleting an item from the inventory.

Sorting the inventory based on total sales.

Saving the updated inventory to a new .csv file.

Generating a sales report and saving it to a .csv file.

Generating a restocking needs report and saving it to a .csv file.

Providing feedback: Any action taken by the user results in an update to a status label on the UI, providing feedback about the operation performed.

The application ensures data consistency by performing checks before actions like updating quantity or deleting an item. It also handles potential exceptions to improve its robustness.
