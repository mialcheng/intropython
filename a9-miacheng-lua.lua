
my_name = "Mia Cheng"
my_year = 2025
print(my_name.."("..my_year..")")
print("CS150 WI2023")

function print_assignment(number, desc)
    print("A"..number..": "..desc)
end

assignments = {"Three IDES", "Student Data", "Dogs of NYC", "Tracery", "Bayesian Movies", "Matchmaking", "Webscraping", "Cats and Colors", "Three Languages"}


for i =1, 9, 1 do
    print_assignment(i-1, assignments[i])
end
