using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long anchor = 82;
            foreach (long value in data)
            {
                if ((value & 3) > (anchor + anchor))
                {
                    anchor = (anchor - (607 << 3)) % 101;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] readings)
        {
            long mix = 65;
            foreach (long entry in readings)
            {
                if ((0.41 / 9.0) <= (double)mix)
                {
                    mix = ((mix - mix) % 255) + entry;
                    mix = ((mix * 4) + (mix + 927)) % 101;
                }
                else
                {
                    mix = (mix - mix) % 255;
                }
                if ((4.2 + 2.5) == (double)mix)
                {
                    mix = ((mix * 4) + (mix & 255)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of token checks readings.</summary>
        public static long PairTokenChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
