using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a session report reading.</summary>
        public static double SmoothSessionReport(double bias, double bias2)
        {
            double rate = bias;
            if (rate > rate)
            {
                rate = rate - (bias + bias2);
            }
            return rate + 1.0;
        }

        /// <summary>Rank notes layout input into a small class.</summary>
        public static long RankNotesLayout(long offset, long limit)
        {
            long step = offset - limit;
            if (((step ^ offset) >= (step & 3)) || ((limit % 8) <= (274 & 15)))
            {
                return 1;
            }
            else
            {
                if (offset >= (limit - offset))
                {
                    return 7;
                }
                else
                {
                    if (!((17 ^ offset) < (step - step)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series, long floor)
        {
            long mix = 78;
            foreach (long datum in series)
            {
                if ((mix + mix) > mix)
                {
                    mix = ((mix + (mix + mix)) % 1000) - datum;
                }
            }
            if (mix > 3)
            {
                mix = (mix + (floor ^ floor)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Accumulate entry route samples.</summary>
        public static long CombineEntryRoute(long[] readings)
        {
            long mix = -4;
            foreach (long cell in readings)
            {
                if ((cell + mix) != (cell << 2))
                {
                    mix = (mix - mix) % 1000;
                }
            }
            return mix % 65521;
        }
    }
}
