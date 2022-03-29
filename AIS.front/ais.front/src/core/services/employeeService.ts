import { defaultEmployee } from "../common/defaultDTO/defaultEmployee";
import { Employee } from "../interfaces/employee";
import axiosInstance from "../../config/getAxious";
import {EMPLOYEE_URL} from "../constants/urlConstants";


export class EmployeeService {
    public static async getAll(): Promise<Employee[]> {
        const result = await axiosInstance.get<Employee[]>(EMPLOYEE_URL)
            .then((result) => result.data)
            .catch(({ response }) => console.log(response.data));
        return result || [];
    }

    public static async getById(companyId: number): Promise<Employee> {
        const result = await axiosInstance.get<Employee>(
            EMPLOYEE_URL+`/${companyId}`)
            .then((result) => result.data)
            .catch((err) => console.log(err));

        return result || defaultEmployee;
    }

    public static deleteById(companyId: number): Promise<any> {
        return axiosInstance.delete(
            EMPLOYEE_URL+`/${companyId}`);
    }

    public static create(company: Employee): Promise<any> {
        return axiosInstance.post(
            EMPLOYEE_URL, { ...company });
    }

    public static update(company: Employee): Promise<boolean> {
        return axiosInstance.put(
            EMPLOYEE_URL, { ...company }, { params: { id: company.id } });
    }
}