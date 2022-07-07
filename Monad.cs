class Monad<T> {
    public T? Value { get; }

    public Monad(T? value) {
        Value = value;
    }

    public bool IsEmpty {
        get => Value == null;
    }

    public Monad<RT> Bind<RT>(Func<T, RT?> function) {
        RT? result = Value != null ? function.Invoke(Value) : default(RT);
        return new Monad<RT>(result);
    }
}