﻿Module EditorBBDD

    Public Function SetsColores()

        Dim set1 As New EditorColores("Default", New List(Of String) From {"#9ca4a7", "#5a6069", "#b8c5c9", "#6b7072", "#6dcff6", "#ff2626", "#b5d1fd", "#dfe3e6", "#47bfff", "#a2acbb", "#2f3238", "#2d2e31", "#3d3f47", "#4c515a", "#2d2f36", "#424242", "#8f3636", "#b9c2cc", "#696773", "#e0e1e6", "#aaacb6", "#7cc4ff", "#313d53", "#161616", "#6278a3", "#74d1ff", "#919191", "#141414", "#49ee51", "#008ada", "#cce0ff", "#3b7fee", "#7eadf8", "#606774", "#7b8392", "#434953", "#17191b", "#333741", "#5c606d", "#22242a", "#8d3b00", "#235ecf", "#cbeeff", "#c1f8ff", "#19b14e", "#c1ffcb", "#2e3136", "#4c91ac", "#d5bf6a", "#c9bdf7", "#91c257", "#a1f410", "#bff02b", "#383c43", "#80aa4d", "#41444e", "#e4ca63", "#9c8fd4", "#e3ffc2", "#90ba3c", "#62813b", "#8277b1", "#e5e5e5", "#b1b1b1", "#6b6a6a", "#9b9b9b", "#c02942", "#d95b43", "#fecc23", "#467a3c", "#4e8ddb", "#7652c9", "#c252c9", "#542437", "#997c52", "#1a1a1a", "#666666", "#cf7f67", "#ccccd5", "#a0545a", "#a0a0a0", "#6e6e6e", "#a2a6ac", "#cccccc", "#6e8d50", "#94a1a6", "#717070", "#8c9193", "#cacbcd", "#b5ffff", "#222830", "#24282f", "#929799", "#2d73ff", "#67b3ff", "#71cbf8", "#151619", "#535c70", "#64c5f2", "#9c9c9c", "#66b9ff", "#89959a", "#393947", "#405358", "#368fa7", "#3a3e46", "#7e7e7e", "#3d5b79", "#536d84", "#dadada", "#b29a7c", "#ffead1", "#66635e", "#216c91", "#3da5da", "#141823", "#5dc2fe", "#886b48", "#ffe9cd", "#5dc3ff", "#cacaca", "#cfdae4", "#c9d3df", "#7a6ebe", "#22252b", "#b6c3f8", "#c1c6cf", "#778494", "#121216", "#121314", "#40464f", "#eceff5", "#18191d", "#9582e7", "#7d6ebc", "#5069e5", "#4367f0", "#80c1f3", "#919fb1", "#4C6B22", "#A4D007", "#799905", "#a4d007", "#41464f", "#8a8a8a", "#707070", "#CCCCCC", "#B1B0B0", "#818080", "#FFFFFF", "#000000", "#2db9ff", "#2c3036", "#86878a", "#289cff", "#61b6e8", "#ec666d", "#8c8d8d", "#656565", "#1d2227", "#2c3138", "#ffffff", "#e4a74a", "#5aa9d6", "#56707f", "#535354", "#8492a4", "#3b3938", "#797979", "#898989", "#686868", "#1b1c20", "#3d424b", "#c9c9c9", "#f5ffd7", "#8592a5", "#dfc408", "#74c069", "#c8f1c2", "#b1b0b0", "#53718d", "#30363d", "#282e35", "#3b444d", "#323941", "#545454", "#3b414a", "#606567", "#2a80ad", "#25282e", "#dbdbdb", "#c44848", "#cdf1ff", "#3e4047", "#d0e1fa", "#bbcddd", "#829ebd", "#292d33", "#ebebeb", "#d2d2d2", "#6a6d73", "#dbe2e6", "#93b3c8", "#1f2126", "#363a43", "#e6e7e8", "#30333b", "#a3a3a3", "#06beff", "#1e2025", "#afafaf", "#3d4450", "#4f5763", "#9199a3", "#09b8fe", "#78bbf2", "#4c4c4c", "#a3cf06", "#353941", "#30343b", "#bbbdbf", "#495059", "#a7aeb4", "#868f98", "#b2b5ba", "#4297f8", "#32373f", "#3d434d", "#464d58", "#e1e1e1", "#5f6875", "#2a2d34", "#3a3f48", "#b7ccd5", "#535b6a", "#8F98A0", "#461F28", "#818181", "#adaeaf", "#777777", "#394149", "#616970", "#4a4a4a", "#2b2f36", "#969696", "#7d0e12", "#808486", "#d3d3d3", "#67c1f5", "#417a9b", "#485562", "#4b76b6", "#bcc0c0", "#8c8c8c", "#40464d", "#363c45", "#2a3f5a", "#aef44c", "#189bff", "#9f9fa0", "#788a92", "#b4b4b4", "#c0c0c0", "#505050", "#808080", "#8082aa", "#acb0e0", "#185c6c", "#3ba2b9", "#a3a4a7", "#dddddd", "#26b7ff", "#636874", "#1e1f23", "#d7d7d7", "#9cffff", "#474f57", "#54697d", "#a1dcf7", "#a8ff00", "#f7f7f7", "#797b83", "#20aaeb", "#2e32ff", "#01a9ea", "#253553", "#82eb2c", "#c1ebff", "#137c16", "#75d3ff", "#88bb46", "#292929", "#a0a1a5", "#9899a1", "#09b9ff", "#131313", "#55aaff", "#2e3036", "#636770", "#d6d6d6", "#003b75", "#81c221", "#202127", "#464141", "#707379", "#3e4e69", "#a2a2a3", "#36383e", "#4c4e57", "#a2e5ff", "#545763", "#44444b", "#63636d", "#575761", "#9e9ead", "#181818", "#6c767f", "#25292e", "#eaeaeb", "#ADAEB2", "#464953", "#c9d3d9", "#b0e9ff", "#c7e5ff", "#b1b4b9", "#DADADB", "#6a737c", "#6d6e70", "#707061", "#7e8391", "#4d4d4d", "#95a6b2", "#809fb7", "#aad8ec", "#bfbfbf", "#222222", "#444850", "#5b616b", "#e1c48a", "#4E5157", "#202020", "#54a5d4", "#201e25", "#909090", "#399aec", "#1C1E26", "#101114", "#ff9696", "#bfc6d4", "#32353c", "#464a53", "#d3eaeb", "#4b4b4b", "#ff7300", "#8f5100", "#b6b6b6", "#6dc7fb", "#2a3649", "#737373", "#bd6500", "#3ea5f1", "#dde1e4", "#8e9093", "#8f98a0", "#a94847", "#6c8da1", "#7092a5", "#576472", "#18181d", "#9edff8", "#812819", "#00ccff", "#888890", "#32333b", "#5f656b", "#6eb6ff", "#ced0da", "#a9a9a9", "#6e7985", "#dedede", "#424853", "#b80505", "#30353b", "#393f49", "#414141", "#189cff", "#373c44", "#3e444d", "#2a2d33", "#202226", "#393d46", "#24262b", "#1b98ff", "#52b8e0", "#332727", "#a71e0b", "#582929"})

        Dim set2 As New EditorColores("Dark Green", New List(Of String) From {"#a7a59c", "#68695a", "#c9c5b8", "#72716b", "#f6d96d", "#2693ff", "#f5fdb5", "#e6e6df", "#ffe347", "#b9bba2", "#37382f", "#30312d", "#44473d", "#585a4c", "#34362d", "#36638f", "#ccccb9", "#6b7367", "#e4e6e0", "#b2b6aa", "#fff97c", "#4e5331", "#99a362", "#ffe874", "#ee4994", "#dabd00", "#faffcc", "#d9ee3b", "#eaf87e", "#717460", "#8f927b", "#515343", "#1b1b17", "#3e4133", "#696d5c", "#282a22", "#000c8d", "#b4cf23", "#fff6cb", "#ffe7c1", "#b11930", "#ffc1d6", "#35362e", "#ac974c", "#8a6ad5", "#cef7bd", "#be57c2", "#d510f4", "#bf2bf0", "#424338", "#a64daa", "#4b4e41", "#8a63e4", "#a5d48f", "#fdc2ff", "#a53cba", "#7d3b81", "#89b177", "#6a6b6b", "#298ec0", "#4376d9", "#5f23fe", "#7a3c65", "#d4db4e", "#6ac952", "#52c987", "#244f54", "#595299", "#6783cf", "#d1d5cc", "#5480a0", "#abaca2", "#8d508d", "#a6a294", "#707171", "#93928c", "#cdcdca", "#ffdab5", "#2f3022", "#2e2f24", "#999892", "#dcff2d", "#ffff67", "#f8e271", "#181915", "#6b7053", "#f2d864", "#fff966", "#9a9789", "#404739", "#585140", "#a78736", "#44463a", "#79793d", "#848353", "#7f7cb2", "#d3d1ff", "#5f5e66", "#917e21", "#dac13d", "#202314", "#feea5d", "#4b4888", "#d0cdff", "#ffea5d", "#e4e4cf", "#dedfc9", "#8abe6e", "#2a2b22", "#e4f8b6", "#cdcfc1", "#939477", "#141612", "#141412", "#4e4f40", "#f4f5ec", "#1c1d18", "#a2e782", "#86bc6e", "#b4e550", "#bef043", "#f3ec80", "#afb191", "#66226b", "#9807d0", "#6f0599", "#9807d0", "#4d4f41", "#b0b1b1", "#808181", "#ffdc2d", "#35362c", "#898a86", "#fff728", "#e8d761", "#66b0ec", "#8d8d8c", "#27271d", "#37382c", "#5a4ae4", "#d6c55a", "#7f7a56", "#545453", "#a2a484", "#38393b", "#1f201b", "#494b3d", "#f5d7ff", "#a2a585", "#5908df", "#c069a0", "#f1c2e0", "#b0b1b1", "#8d8c53", "#3d3d30", "#353528", "#4d4d3b", "#414132", "#494a3b", "#676660", "#ad992a", "#2d2e25", "#4886c4", "#fff4cd", "#45473e", "#f6fad0", "#dddcbb", "#bcbd82", "#323329", "#72736a", "#e6e5db", "#c8c393", "#25261f", "#414336", "#e8e8e6", "#393b30", "#ffc406", "#24251e", "#4e503d", "#61634f", "#a2a391", "#feca09", "#f2ec78", "#9706cf", "#3f4135", "#3a3b30", "#bfbfbb", "#585949", "#b4b4a7", "#989886", "#b9bab2", "#f2f842", "#3e3f32", "#4b4d3d", "#565846", "#73755f", "#32342a", "#46483a", "#d5cfb7", "#676a53", "#a0a08f", "#1f3c46", "#afafad", "#494939", "#707061", "#35362b", "#0e4a7d", "#868580", "#f5e267", "#9b8f41", "#626248", "#acb64b", "#c0bebc", "#4d4d40", "#444536", "#575a2a", "#e64cf4", "#fff018", "#a0a09f", "#928d78", "#97aa80", "#cae0ac", "#6c5218", "#b9913b", "#a6a7a3", "#ffdb26", "#717463", "#22231e", "#ffce9c", "#575747", "#7d7d54", "#f7e7a1", "#d700ff", "#808379", "#ebc720", "#9bff2e", "#eab701", "#4c5325", "#eb2ce2", "#fff4c1", "#7c1345", "#ffe675", "#b446bb", "#a4a5a0", "#9ea198", "#ffca09", "#ffff55", "#34362e", "#6e7063", "#757500", "#b321c2", "#252720", "#414446", "#787970", "#64693e", "#a3a3a2", "#3c3e36", "#54574c", "#ffeba2", "#5f6354", "#484b44", "#686d63", "#5c6157", "#a6ad9e", "#7f7f6c", "#2e2e25", "#ebebea", "#b1b2ad", "#505346", "#d9d7c9", "#ffeeb0", "#fffdc7", "#b8b9b1", "#dbdbda", "#7c7c6a", "#70706d", "#696170", "#8d917e", "#b2b095", "#b7b480", "#ecdfaa", "#4e5044", "#696b5b", "#998ae1", "#56574e", "#d4c354", "#20251e", "#ece539", "#23261c", "#131410", "#96cbff", "#d1d4bf", "#3a3c32", "#515346", "#ebe0d3", "#000dff", "#0a008f", "#fbe86d", "#46492a", "#0700bd", "#f1e43e", "#e4e4dd", "#93938e", "#a0a08f", "#4777a9", "#a19b6c", "#a59e70", "#727257", "#1b1d18", "#f8e49e", "#193e81", "#ffb300", "#8c9088", "#383b32", "#6b6b5f", "#ffff6e", "#d6dace", "#85856e", "#515342", "#055fb8", "#3b3b30", "#474939", "#ffef18", "#434437", "#4c4d3e", "#32332a", "#252620", "#444639", "#2a2b24", "#fff41b", "#e0c152", "#272d33", "#0b46a7", "#294158"})

        Dim set4 As New EditorColores("Blue", New List(Of String) From {"#001a84", "#05317e", "#04236c", "#46cbfd", "#004ec3", "#83e1fe", "#059cd8"})

        Dim lista As New List(Of EditorColores) From {
            set1,
            set2,
            set4
        }

        Return lista

    End Function

End Module
