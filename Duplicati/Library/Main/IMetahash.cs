//  Copyright (C) 2011, Kenneth Skovhede

//  http://www.hexad.dk, opensource@hexad.dk
//
//  This library is free software; you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as
//  published by the Free Software Foundation; either version 2.1 of the
//  License, or (at your option) any later version.
//
//  This library is distributed in the hope that it will be useful, but
//  WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
//  Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public
//  License along with this library; if not, write to the Free Software
//  Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
using System;
using System.Collections.Generic;

namespace Duplicati.Library.Main
{
    /// <summary>
    /// Interface for describing metadata
    /// </summary>
    public interface IMetahash
    {
        /// <summary>
        /// The base64 encoded hash of the metadata
        /// </summary>
        string Hash { get; }
        /// <summary>
        /// The size of the metadata in bytes
        /// </summary>
        long Size { get; }
        /// <summary>
        /// The UTF-8 encoded json element with the metadata
        /// </summary>
        byte[] Blob { get; }
        /// <summary>
        /// The lookup table of contained metadata values
        /// </summary>
        Dictionary<string, string> Values { get; }
    }
}
