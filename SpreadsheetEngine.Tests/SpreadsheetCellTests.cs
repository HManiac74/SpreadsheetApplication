﻿// <copyright file="SpreadsheetCellTests.cs" company="Benjamin Michaelis">
// Copyright (c) Benjamin Michaelis. ID: 11620581. All rights reserved.
// </copyright>

using System;
using Xunit;

namespace SpreadsheetEngine.Tests
{
    /// <summary>
    /// Test methods in the spreadsheetClass.
    /// </summary>
    public class SpreadsheetCellTests
    {
        /// <summary>
        /// Constructs class for abstract Class SpreadsheetCell.
        /// </summary>
        public class CellTests : SpreadsheetCell
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="CellTests"/> class.
            /// Constructs object for abstract Class SpreadsheetCell.
            /// </summary>
            /// <param name="rowIndex">The row index of cell.</param>
            /// <param name="columnIndex">The column index of the cell.</param>
            public CellTests(int rowIndex, int columnIndex)
                : base(rowIndex, columnIndex)
            {
            }
        }

        /// <summary>
        /// Test that when given the int 1 for a column number it returns A.
        /// </summary>
        [Fact]
        public void ColumnLetterToNumber_A_return1()
        {
            CellTests sut = new(1, 1);
            Assert.Equal("A", sut.ColumnIntToLetter(1));
        }

        /// <summary>
        /// Test that when given the int 26 for a column number it returns Z.
        /// </summary>
        [Fact]
        public void ColumnLetterToNumber_26_returnZ()
        {
            CellTests sut = new(1, 1);
            Assert.Equal("Z", sut.ColumnIntToLetter(26));
        }
    }
}
