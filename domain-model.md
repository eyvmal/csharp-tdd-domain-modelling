#Domain Models In Here
| Classes         | Methods                                     | Scenario                       | Outputs       |
|-----------------|---------------------------------------------|--------------------------------|---------------|
| `CohortManager` | `count(List<String> cohorts, string name)`  | Counts occurances              | occurances    |
| `CheckoutTotal` | `checkout(List<Item> cart)`                 | Sum price of items in the cart | cart total    |
| `Receipt`       | `receipt(List<Item> cart)`                  | Prints items, price and amount | Receipt class |