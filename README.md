# FizzBuzz
Technical Screening Exercise
Thank you for taking the time to participate in this challenge. Please read carefully all the instructions below and don’t
hesitate to contact us in case of any doubt. You should use the programming language and tools that you feel
more comfortable with, so we’ll be able to see your full potential. You should NOT find this exercise to be particularly
difficult. It is designed to be a straightforward coding exercise, and it should take you no more than 90 minutes.

Things we are very picky about:
● Test Coverage – the solution should be developed using TDD (test-first) and with excellent unit test
coverage.

● Simplicity – We value simplicity as an architectural virtue and a development practice. Solutions should
reflect the difficulty of the assigned task, and should NOT be overly complex. Layers of abstraction, patterns,
or architectural features that aren’t called for should NOT be included.

● Self-explanatory code – the solution must speak for itself. Multiple paragraphs explaining the solution are a
sign that isn’t straightforward enough to understand purely by reading the code.

● Should be easy to run the program and tests from the command line. If you need supporting scripts, feel free
to add them to your submission.

Instructions
Step 1
Please keep the code for this step in a separate folder called: Step1
Write a program that produces the following for a contiguous range of numbers:

● the number

● 'fizz' for numbers that are multiples of 3

● 'buzz' for numbers that are multiples of 5

● 'fizzbuzz' for numbers that are multiples of 15

e.g.: if I run the program over a range from 1-20 I should get the following result:
1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz
Step 2
Please keep the code for this step in a separate folder, isolated from the previous step, called: Step2
Change your existing FizzBuzz solution to perform the following:

● If the number contains a three you must output the text 'lucky'

● This overrides any existing behaviour

e.g.: if I run the program over a range from 1-20 I should get the following output:

1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz
Step 3
Please keep the code for this step in a separate folder, isolated from the previous step, called: Step3
Finally, change your existing solution to perform the following:

● Produce a report at the end of the program showing how many times the following were output

○ fizz

○ buzz

○ fizzbuzz

○ lucky

○ an integer

e.g.: if I run the program over a range from 1-20 I should get the following output:
1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz

fizz: 4

buzz: 3

fizzbuzz: 1

lucky: 2 integer: 10

(integer is 10 because there were 10 numbers that were not altered in any way)
Code submission
We will send you a link to a private repo on Bitbucket to submit your code. Please do your commits in a way we can
see how the code evolved, and write code that you would be happy delivering to a paying client.
Run these commands inside your local folder after cloning the repo to ensure your submission is anonymous:
git config --local user.name Anonymous
git config --local user.email anonymous@example.com
Please provide an automated build file that compiles your code and runs the tests. Submissions without an
automated build will not be accepted.
Please don’t commit compiled code to the repo. We won’t use it, and it only makes the repo unnecessarily big.
Anonymous submission
We practice a blind review process for exercise submissions, so please don’t include your name (or any other
personal detail that might identify you) anywhere in your submitted source code, documentation, or comments. This
makes our interview process as fair and systematic as possible.
Please use the example.com domain as the reference in your language naming conventions. For instance, in Java
submissions please use the package name com.example; in C# submissions please use the namespace Example.
The person who reviews your submission won’t have access to your CV or know anything about you, including your
name. Your identification in the email communications with our recruitment won’t be shared with the reviewer.

Good Luck!
