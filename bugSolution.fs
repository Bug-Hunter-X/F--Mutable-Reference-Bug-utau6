let mutable x = 1
let y = ref x

let mutable z = 2

x <- 3
printf "%d %d" x !y