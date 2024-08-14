#Domain Models In Here
| Classes          | Methods                                     | Scenario                       | Outputs        |
|------------------|---------------------------------------------|--------------------------------|----------------|
| `CohortManager`  | `count(List<String> cohorts, string name)`  | Counts occurances              | occurances     |
| `ShoppingCenter` | `checkout(List<Item> cart)`                 | Sum price of items in the cart | cart total     |
| `ShoppingCenter` | `receipt(List<Item> cart)`                  | Prints items, price and amount | list of values |