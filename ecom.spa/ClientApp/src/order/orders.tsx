import { Order } from "../types/order";
import { Product } from "../types/product";
import { useState } from "react";

type Args = {
    product: Product;
};

const Orders = ({ product }: Args) => {
    const addOrderMutation = useAddOrder();
    const emptyOrder = {
        orderId: "",
        productId: product.productId,
        customerId: "",
        productCount: 0,
        orderPrice: 0,
        orderState: "",
    }

    const [order, setOrder] = useState<Order>(emptyOrder);

    const onOrderSubmitClick = () => {
        addOrderMutation.mutate(order);
        setOrder(emptyOrder);
      };

      return (
        <>          
          <div className="row">
            <div className="col-4">
              Quantity
            </div>
            <div className="col-4">
              <input
                id="productCount"
                className="h-100"
                type="number"
                value={order.productCount}
                onChange={(e) =>
                    setOrder({ ...order, productCount: parseInt(e.target.value) })
                }
                placeholder="Quantity"
              ></input>
            </div>
            <div className="col-2">
              <button
                className="btn btn-primary"
                onClick={() => onOrderSubmitClick()}
              >
                Add
              </button>
            </div>
          </div>
        </>
      );
}

