import axios, { AxiosError, AxiosResponse } from "axios";
import { useMutation, useQuery, useQueryClient } from "react-query";
import Config from "../config";
import { Order } from "../types/order";
import Problem from "../types/problem";

const useAddOrder = () => {
    const queryClient = useQueryClient();
    return useMutation<AxiosResponse, AxiosError<Problem>, Order>(
        (o) => axios.post(`${Config.baseApiUrl}/order/${o.orderId}`, o),
        {
          onSuccess: (resp, order) => {
            queryClient.invalidateQueries(["order", order.orderId]);
          },
        }
      );
}