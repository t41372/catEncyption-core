# catEncyption

Release:
- [Windows](https://github.com/t41372/catEncyption-core/releases)



This is a program that help human to encrypt their message into the form of Meow!! 

#### How does it works?

This program basically do something like this to encode your text:

> your text -> base64 -> unicode (number) -> binary -> Meow Meow!!

and follow the reverse steps to decode text.

#### Example

For example, encode the following texts

~~~
支持中文
~~~

and

~~~
Hello World
~~~



will become

~~~
喵喵!喵!喵 喵喵喵!!!! 喵!喵!!喵喵 喵喵喵!喵喵! 喵喵!喵!喵 喵喵!喵喵喵喵 喵喵喵喵!!喵 喵!!!!喵! 喵喵!喵!喵 喵!!喵喵!! 喵喵!喵!!喵 喵喵喵!喵!! 喵喵!喵!喵 喵喵喵!!!! 喵喵!!!!喵 喵!!喵!!!
~~~

and

~~~
喵!喵!!喵喵 喵!!!喵喵喵 喵!喵!喵喵! 喵喵喵!!喵喵 喵喵!!!喵! 喵!!!喵喵喵 喵喵喵!!! 喵喵!!喵喵喵 喵!喵!喵喵! 喵喵!!喵! 喵喵喵!!喵 喵喵喵喵!!喵 喵喵!!!喵! 喵!!!喵喵喵 喵!喵!!!喵 喵喵喵喵!喵
~~~





#### Existing Problems

- [ ] it crash when you paste too much content into the decoder