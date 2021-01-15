const mongoose = require('mongoose');

const userSchema = mongoose.Schema({
    name: {
        type: String,
        required: [true, 'required']
    },
    email: {
        type: String,
        required: [true, 'required']
    },
    pwd: {
        type: String,
        required: [true, 'required']
    },
    createdAt: {
        type: Date,
        default: new Date()
    }
})

const User = mongoose.model('user', userSchema)
module.exports = User