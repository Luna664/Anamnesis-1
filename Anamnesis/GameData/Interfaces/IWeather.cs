﻿// © Anamnesis.
// Developed by W and A Walsh.
// Licensed under the MIT license.

namespace Anamnesis.GameData
{
	using System.Windows.Media;

	public interface IWeather : IRow
	{
		ImageSource? Icon { get; }
		ushort WeatherId { get; }
	}
}
