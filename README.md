# CSIS1175-GroceryManagementSystem
This application, written in C# and designed as a Windows Form application, serves as a Grocery Management System. Its main purpose is to manage a grocery store's inventory, allowing for efficient tracking of items, their quantities, sales, and restocking needs.

Key features include:

Loading inventory data from a CSV file: The app reads data from a file named "superstore.csv", containing information about various grocery items, such as their ID, name, unit price, quantity needed for restock, initial quantity, quantity sold, and quantity restocked. Each item is represented as an instance of the Grocery class and is stored in a List<Grocery> data structure.

Displaying inventory data: The loaded grocery items are displayed in a ListBox on the application's user interface, and the user can select individual items to view and update specific details.

Updating item quantities: The user can increment the quantity sold and the quantity restocked of a selected item. The updated item information replaces the previous data both in the grocery list and in the ListBox.

Deleting items: Users can delete a selected item from the grocery list and the ListBox.

Sorting items: The grocery list can be sorted in descending order by total sales using a button click.

Saving updated data: The app allows the user to save the updated inventory data into a new CSV file named "updatedgrocery.csv".

Generating reports:

A sales report can be generated, saved into a CSV file named "grocerysales.csv", and lists only the items that have been sold, ordered by their total sales.
A restock needs report can be generated, saved into a file named "groceryrestocks.csv", and includes items whose available quantity is less than the minimum quantity needed for restock.
Providing feedback: Any action taken by the user results in an update to a status label on the UI, providing feedback about the operation performed.

This Grocery Management System application can greatly enhance the efficiency of managing a grocery store's inventory, streamline operations, and provide valuable sales and restocking insights.
