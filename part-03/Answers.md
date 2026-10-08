# Part 03 — Answers

---

## BlockedUsers

* **Time complexity before:** O(n × m), because the blocked users were stored in a `List` and each request could require searching through the whole list.
* **Time (ms) before:** ~500 ms (estimated).
* **What did you change?** I changed the blocked IDs lookup to use a `HashSet<int>`. This makes checking whether an ID is blocked much faster because `HashSet.Contains()` has an average O(1) lookup time.
* **Time complexity after:** O(n + m) overall, with O(1) average lookup for each request.
* **Time (ms) after:** 1 ms.

---

## Students

* **What was the problem?** The program works with 1,000,000 students, but it only needs to print the first 3 students. Creating all students at once would waste memory and processing time.
* **What did you change?** I used `yield return` in `GetAllStudents()` to make the students generated lazily. This means each student is created only when the program requests it, so when the loop stops after the first 3 students, the remaining students are never created.
