/***************************************************************************
 *                              TargetFlags.cs
 *                            -------------------
 *   begin                : Marc 9, 2014
 *   copyright            : (C) The RunUO EC Software Team
 *   email                : mutila@gmail.com
 *
 *   $Id: TargetFlags.cs 4 2006-06-15 04:28:39Z mark $
 *
 ***************************************************************************/

/***************************************************************************
 *
 *   This program is free software; you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation; either version 2 of the License, or
 *   (at your option) any later version.
 *
 ***************************************************************************/

using System;

namespace Server.Targeting
{
	public enum TargetFlags : byte
	{
		None = 0x00,
		Harmful = 0x01,
		Beneficial = 0x02,
	}
}