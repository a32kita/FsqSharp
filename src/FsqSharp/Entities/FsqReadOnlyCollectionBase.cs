using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;

namespace FsqSharp.Entities
{
    public class FsqReadOnlyCollectionBase<TItem> : IReadOnlyCollection<TItem>
    {
        // 公開プロパティ

        [JsonIgnore]
        public TItem this[int index]
        {
            get => this.Items[index];
        }


        [JsonProperty("count")]
        public int CountAll
        {
            get;
            set;
        }

        [JsonIgnore]
        public int Count
        {
            get => this.Items == null ? 0 : this.Items.Length;
        }

        [JsonProperty("items")]
        public TItem[] Items
        {
            get;
            set;
        }


        // 公開メソッド

        public IEnumerator<TItem> GetEnumerator()
        {
            return ((IEnumerable<TItem>)Items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)Items).GetEnumerator();
        }
    }
}
