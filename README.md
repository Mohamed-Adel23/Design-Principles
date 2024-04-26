# Design Principles 

## What are Design Principles? 🔨
Abstract (High-Level) guidelines, suitable to all programming languages, to improve the object-oriented design of the software to be produced in a high quality, 
so the code becomes more *maintainable*, *flexible*, *reusable*, and *extensible*.
> Here, in this repository I will discuss and explain **SOLID** principles with UML diagrams and snippets of codes to make the principle easy to understand.

## Prerequisites ✍
- You should have a good understanding of **Object-Oriented Programming OOP** before dig dive into this repository.

## Some Terms To Understand Before Getting Strated 🙂
### [1] Encapsulate What varies:
The **Encapsulate What Varies** principle is a design guideline in software engineering that advocates encapsulating the parts of a system that are likely to change. 
It is one of the key principles of the *SOLID principles*, specifically associated with the "Open/Closed Principle" (OCP).

**The logic is:** The code that keeps changing, candidate to be highly reused, therefore this may cause ***inconsistency*** in the code and the code will break the ***DRY(Don't Repeat Yourself)*** concept, so we should encapsulate what varies.

**Problems We Faced Without Applying This Concept**
- Breaking DRY (Don't Repeat Yourself) concept
- Difficult to extend a method
- Data inconsistency

**Advantages of Using This Concept**
- Respect DRY concept
- Easy to extend a Method
- Respect (Open/Closed Principle (OCP))

**Example:** You're tasked to design a system for a Pizza Restaurant which has different types of pizza 🍕

***Bad Design*** ☹️

![1](https://github.com/Mohamed-Adel23/Design-Principles/assets/119868046/93ca9949-07e4-4910-b7b2-5a45e00c2748)

Here we have a method called (Order) which recieve the type of pizza and comparing it with the existing types (variable code) and then Prepare, Cook and Cut the pizza and finally returning it. the problem here is there is a variable code with constant one, which should be isolated (encapsulated) to avoid duplication, incosistency, ... etc

***Good Design*** 😊

![2](https://github.com/Mohamed-Adel23/Design-Principles/assets/119868046/ea5b6814-2594-4c24-87d4-e9e5be41feb0)

Here we isolate the variable code in the (Create) Method which will create the Pizza based on the given type, so we managed to avoid many problems.

### [2] Inheritence VS Composition

## Resources 📚
- [x] [Eng. Essam Abdelnabi](https://youtube.com/playlist?list=PL4n1Qos4Tb6ThSyydEJTm7xJ3qEwE8Oyu&si=fx9eoLqGwhnXSO9f)
- [x] [ChatGPT](https://chat.openai.com/)  
