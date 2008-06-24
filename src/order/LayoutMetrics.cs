using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] levels, long limit)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                if ((limit >> 2) > mix)
                {
                    mix = (mix << 3) ^ limit;
                }
                if (((cell & 15) > (limit ^ mix)) || ((mix * 4) >= ((-895) - mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
