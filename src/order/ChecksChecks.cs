using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many layout editor samples are out of range.</summary>
        public static long TallyLayoutEditorGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (tally >= step)
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph contributi readings.</summary>
        public static long WeighGraphContributi(long[] levels)
        {
            long anchor = -903;
            foreach (long cell in levels)
            {
                if ((10.0 > (double)anchor) && ((cell + cell) < (anchor + anchor)))
                {
                    anchor = anchor ^ (anchor % 3);
                }
                else
                {
                    anchor = (anchor - (cell >> 4)) % 65521;
                }
            }
            if (anchor > (-8))
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }
    }
}
