﻿public static partial class Results
{
	public static Result<T> Errors<T>(string Type, string Detail, IReadOnlyCollection<FieldError> errors)
		=> Results.Problem<T>(Type, Detail, errors);

    public static Result<T> Errors<T>(string Type, string Detail, List<FieldError> errors) 
        => Problem<T>(Type, Detail, errors.AsReadOnly());

    public static Result<T> Errors<T>(string Type, string Detail, IEnumerable<FieldError> errors) 
        => Problem<T>(Type, Detail, errors.ToArray());


	public static Result<T> Errors<T>(T Value, string Type, string Detail, IReadOnlyCollection<FieldError> errors)
		=> Results.Problem<T>(Value, Type, Detail, errors);

    public static Result<T> Errors<T>(T Value, string Type, string Detail, List<FieldError> errors)
        => Problem<T>(Value, Type, Detail, errors.AsReadOnly());
    public static Result<T> Errors<T>(T Value, string Type, string Detail, IEnumerable<FieldError> errors)
        => Problem<T>(Value, Type, Detail, errors.ToArray());
}
