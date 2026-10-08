# Part 01 — answers

---

## ShippingCostCalculator

* **What was the problem?**
  The `ShippingCostCalculator` had to handle different shipping carriers, such as Aramex and FedEx, in the same place. Adding more carriers would make the class harder to maintain.

* **What did you change?**
  I separated the shipping logic for the different carriers and used polymorphism so each carrier can have its own implementation. The calculator can now work with different carriers more easily.

---

## OrderProcessor

* **What was the problem?**
  The `OrderProcessor` was depending directly on specific notification or processing implementations, which made it harder to change the code.

* **What did you change?**
  I changed the design to use an abstraction so the `OrderProcessor` is less dependent on a specific implementation. This makes it easier to extend later.

---

## Notifications

* **What was the problem?**
  The notification logic was not easy to extend when adding different notification types.

* **What did you change?**
  I added separate notification classes for the different types. For example, `UrgentScheduledEmailNotification` is used for scheduled email notifications, while `UrgentSmsNotification` is used for SMS notifications. They follow the same notification abstraction.

---

## Proof

* **New carrier file(s):**
  `Aramex`
  `FedEx`

* **New notification channel file(s):**
  `UrgentScheduledEmailNotification`
  `UrgentSmsNotification`

* **Existing classes left unchanged? (yes/no):**
  Yes.
