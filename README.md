# Command Design Pattern

### Type
Behavioral Design Pattern

### What problem it solves?
+ Directly invoking methods on objects creates tight coupling between the sender (invoker) and receiver (executor), making the system harder to modify.
+ If new actions need to be introduced, modifying the sender can become complex and error-prone.
+ Undo/redo functionality, logging, or queuing requests efficiently is difficult with tightly coupled systems.

### How it solves the problme?
+ The Command pattern encapsulates a request as an object (Command), allowing it to be stored, executed, or manipulated independently.
+ The sender (invoker) does not need to know the actual implementation details of the receiver (executor); it simply calls the execute() method of the Command object.
+ Commands can be stored in history stacks for undo/redo functionality.
+ New commands can be introduced without modifying the sender, improving flexibility and maintainability.
In our example, lets say we have a home appliance remote controller and we want to switch on/off certain devices on one click rather than switching on all devices one by one. In such case, we stack commands to switch on or off in an object. Then, this object is used to operate all devices.

### Limitations
+ Managing a large number of different commands may lead to excessive class creation.
+ Some implementations require extra logic for undo/redo actions, increasing system overhead.

### Diagram
![Design_Pattern_Command](https://github.com/user-attachments/assets/08d72ec2-58b8-4702-8775-70a811e2b41f)
