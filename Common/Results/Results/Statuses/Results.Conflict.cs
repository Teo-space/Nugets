﻿public static partial class Results
{
	public static Result<T> Conflict<T>(string Detail)
		=> Problem<T>(Statuses.Conflict, Detail);

	public static Result<T> ConflictAlreadyExists<T>(string Info)
		=> Conflict<T>($"{typeof(T)} ({Info}) already exists");

}