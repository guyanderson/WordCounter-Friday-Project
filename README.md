# _WordCounter_

#### _Enter a word. Enter a sentence. The program will return the number of times the word is in the sentence. 6/5/17_

#### By _**Guy Anderson**_

## Description

_The program will take 2 inputs from the user: a word, and a sentence. The program will look for an exact match of the users word inside the sentence. Teh program will then return the user input to the screen, along with the number of times the word appears in the sentence._

## Setup/Installation Requirements

* Go to Github repository page.
* Click the "download or clone" button and copy the link
* In your computers terminal type "git clone" & paste the copied link.
* Run dnu restore in terminal
* Run dnx kestrel in terminal
* Open browser, type localhost:5004 for url
* Prepare to be amazed!

## Specs
| Behavior      | Input | Output |
| ------------- |------------- |-------------|
| home page will take user input for comparison word | cat | cat |
| home page will take user input for comparison sentence | the cat eats cat food | the cat eats cat food |
| program will identify matching words | cat / cat | true |
| program will split user sentence up by words | the cat eats cat food | the, cat, eats, cat, food |
| program will count how many time the comparison word is in the sentence | cat / the cat eats cat food | 2 |
| results page will display the users original word, sentence, and how many times the word was found in the sentence | cat / the cat eats cat food | 2 |
| Program will accept lower and upper case to be equal | the / The cat eats cat food | 1  |
| Program will ignore common punctuation | food / the cat eats cat food. | 1 |



## Known Bugs

_Punctuation and capitalization are not taken into consideration._

## Support and contact details

_As always, there is no support for this product_

## Technologies Used

_C#, Razor, Nancy, bootstrap_

### License


Copyright (c) 2017 FunGuy entertainment
