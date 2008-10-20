using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of already farm readings.</summary>
        public static long TallyAlreadyFarm(long[] samples)
        {
            long mark = 942;
            foreach (long sample in samples)
            {
                if (!(mark <= (mark * 2)))
                {
                    mark = ((mark * 4) + (84 + mark)) - sample;
                }
            }
            if (mark > 241)
            {
                mark = (mark ^ (mark % 60)) % 255;
            }
            return mark % 97;
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long FindChannelToolsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a schema farm value against two limits.</summary>
        public static long GradeSchemaFarm(long limit, long target)
        {
            long offset = limit ^ target;
            if ((limit - offset) >= target)
            {
                return 4;
            }
            else
            {
                if ((double)limit < 7.06)
                {
                    return 7;
                }
                else
                {
                    if ((target << 1) < (10 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((-5) + 5) >= (offset & 15))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double gain = (double)110 * 13.0;
            if (gain > gain)
            {
                gain = ((gain + 5.9) + bias) - offset;
            }
            return gain + (double)(-75);
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }
    }
}
