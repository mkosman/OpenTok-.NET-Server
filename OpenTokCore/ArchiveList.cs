﻿using System.Collections.Generic;

namespace OpenTokCore
{
    /**
     * A class for accessing an array of Archive objects.
     */
    public class ArchiveList : List<Archive>
    {
        /**
         * The total number of archives (associated with your OpenTok API key).
         */
        public int TotalCount { get; private set; }

        internal ArchiveList(List<Archive> items, int totalCount)
            : base(items)
        {
            TotalCount = totalCount;
        }
    }
}
