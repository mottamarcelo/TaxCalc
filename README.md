# TaxCalc
OOP Exercise - Abstract Classes and Methods

Make a program to read the data of N taxpayers (N supplied by the user), which can be individuals or companies, and then display the amount of tax paid by each one, as well as the total tax collected.
The data for individuals is: name, annual income and health expenses. The data for companies are name, annual income and number of employees. The rules for calculating tax are are as follows:

Individuals: people whose income is below 20000.00 pay 15% tax. People with income from 20000.00 onwards pay 25% tax. If the person had health expenses, 50% of these expenses are deducted from the tax.
Example: a person whose income was 50000.00 and had 2000.00 in health expenses, the tax is: (50000 * 25%) - (2000 * 50%) = 11500.00

Company: legal entities pay 16% tax. However, if the company has more than 10 employees, it pays 14% tax.
Example: a company whose income was 400000.00 and has 25 employees, the tax is: 400000 * 14% = 56000.00
