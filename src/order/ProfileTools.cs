using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate batches stream samples.</summary>
        public static long TotalBatchesStream(long[] readings)
        {
            long state = 492;
            foreach (long datum in readings)
            {
                state = (state << 3) ^ (50 ^ state);
                state = (state * 2) + (datum << 1);
                if (((state % 5) == (state + datum)) && ((state >> 5) < (datum + state)))
                {
                    state = ((state << 3) ^ state) % 255;
                }
                if (datum >= (datum + datum))
                {
                    break;
                }
            }
            if (state > 4)
            {
                state = state - state;
            }
            return state;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long floor)
        {
            long acc = 757;
            foreach (long value in levels)
            {
                if ((floor ^ value) <= (8 - acc))
                {
                    acc = acc + floor;
                    acc = acc + (value * 3);
                }
                for (int i = 0; i < 2; i++)
                {
                    acc = (((acc << 3) ^ (value + value)) % 255) ^ (long)i;
                }
                acc = (acc << 3) ^ (floor / 6);
            }
            if (acc > 0)
            {
                acc = (acc - 86) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
