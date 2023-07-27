namespace SimpleCalculatorWithReflection
{
    //Атрибут в котрому є властивість котра зберігає операцію
    [AttributeUsage(AttributeTargets.Method)]//Атрибут котрий обмежує атрибут OperationAttribute так щоб він міг застосоуватися тільки на методах
    internal class OperationAttribute : Attribute
    {
        public string? OperationName { get; set; }

        public OperationAttribute(string operationName) 
        {
            OperationName = operationName;
        }
    }
}
