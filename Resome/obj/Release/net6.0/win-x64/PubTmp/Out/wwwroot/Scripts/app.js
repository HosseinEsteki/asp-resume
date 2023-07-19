const app = Vue.createApp({
    // template: "<h2>Mamareza</h2>",
    data() {
        return {
            counter: 1,
            part1: true,
            part2: false,
            part3: false,
            part4: false,
            part5: false,
            part6: false,
            next_button: true,
            pervius_button: false,
            submit_button: false
        }
    },
    methods: {
        next() {
            var count = ++this.counter;
            this.part1 = false
            this.part2 = false
            this.part3 = false
            this.part4 = false
            this.part5 = false
            this.part6 = false
            this.pervius_button=true
            if (count == 1) {
                this.part1 = true
                this.pervius_button = false
            }
            if (count == 2)
                this.part2 = true
            if (count == 3)
                this.part3 = true
            if (count == 4)
                this.part4 = true
            if (count == 5)
                this.part5 = true
            if (count == 6) {
                this.submit_button=true
                this.part6 = true
                this.next_button = false
                this.submit_button = true

            }
            


        },
        pervius() {
            var count = --this.counter;
            this.part1 = false
            this.part2 = false
            this.part3 = false
            this.part4 = false
            this.part5 = false
            this.part6 = false
            this.next_button = true
            if (count == 1) {
                this.part1 = true
                this.pervius_button=false
            }
            if (count == 2)
                this.part2 = true
            if (count == 3)
                this.part3 = true
            if (count == 4)
                this.part4 = true
            if (count == 5)
                this.part4 = true
            if (count == 6) {
                this.part6 = true
                this.next_button = false
                this.submit_button= true

            }
        }
    }

});
app.mount("#form1")

const resume = Vue.createApp({
    methods: {
        print() {
            window.print();
        }
    }
});
resume.mount("#resume");