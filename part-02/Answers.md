# Part 02 — answers

---

## Reports

* **What was the problem?**
  The three report classes had almost the same `Export()` process. The steps `Load`, `Validate`, `Format`, and `Save` were repeated in each class. The only real difference was how the report was formatted.

* **What did you change?**
  I created a base class called `ReportExporter` and moved the common `Export()` process into it. The `FormatReport()` method is abstract, so each report type can implement its own formatting.

* **Why did you choose that approach?**
  I chose the Template Method pattern because the overall process is the same for all reports, but the formatting is different. This avoids repeating the same code and makes it easier to add another report format later.

---

## Enrollment

* **What was the problem?**
  The `Program` had to work directly with several different services such as `PaymentGateway`, `SeatInventory`, `InvoiceGenerator`, and `EmailService`. This made the enrollment process longer and harder to manage.

* **What did you change?**
  I created an `EnrollmentFacade` that handles the enrollment process. It calls the payment, seat reservation, invoice, and email services internally. Now the `Program` only needs to call `Enroll()`.

* **Why did you choose that approach?**
  I chose the Facade pattern because it gives the `Program` one simple method instead of making it deal with all the different services. It makes the enrollment process easier to use and keeps the details inside the facade.
