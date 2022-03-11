# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

The overall purpose of this program is to provide an entertaining game for the user. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

In this program the user is prompted to make a five letter word guess and the yellow letters are in this word, the green letters are in the word and in the right place, and the red letters are not in the word at all. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The user types the input, which is a five letter guess into the terminal and will receive an output explaining information on the letters as to whether they are in the word and in the right place, in the word and in the wrong place, or not in the word at all.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> words = new List<string>();

            words.Add("sharp");
            words.Add("white");
            words.Add("plays");
            words.Add("light");
            words.Add("reads");
            words.Add("rupee");
            words.Add("blues");
            words.Add("write");
            words.Add("mould");
            words.Add("lapse");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
 Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];
            // 3. Generate a random number between 0 and `words.Count` and store the result in
            //    a variable called `ix`
            // 4. Return the word at position `ix`. (e.g. `words[ix]`)
            return randomWord;
        }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "words".

### 3b iv.

Describes what the data contained in the list represents in your program

The data stored in the list represents the possible correct answers in my program.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

A single variable can store all possible correct words by using a list. A variable would need to be made for every possible word without a list. The list allows the correct word to be chosen by a random index. Each possible outcome would need to be coded for using else if / if statements without a list.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static void DisplayInfo(string guess, string correct)
        {
            if (guess.Length != correct.Length)
            {
                throw new Exception($"Expected {guess} and {correct} to have the same length.");
            }

            int index = 0;
            while (index < correct.Length)
            {
                char guessChar = guess[index];
                char correctChar = correct[index];
                DisplayCharInfo(guessChar, index, correct);
                index = index + 1;
            }



            // 1. Validate that the guess and correct word are the same length
            // 2. If the lengths do not match, throw an exception
            // 3. If they match, iterate through each character:
            // Use the DisplayCharInfo method to determine what color to print the character
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
DisplayInfo(guess, correct);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

DisplayInfo() is called in order to compare between the word guessed and the correct word by showing each letter and whether the letter is correct and in the right place, correct and in the wrong place, or wrong entirely. This is used every time the user inputs a guess.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Validate that the guess and correct word are the same length
2. If the lengths do not match, throw an exception
3. If they match, iterate through each character:
    * Use the DisplayCharInfo method to determine what color to print the character

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

Program.DisplayInfo("grass", "drive");

Second call:

Program.DisplayInfo("chocolate", "drive");

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Testing the the guess is equal in length to the correct word.

Condition(s) tested by the second call:

Testing that the guess is not equal in length to the correct word.

### 3d iii.

Result of the first call:

You should see a red 'g' in position 0, a green 'r in position 1, a red 'a' in position 2, a red 's' in position 3, and a red 's' in position 4.

Result of the second call:

Expect an exception to be thrown.