const express = require("express");
const router = express.Router();
const User = require("../../model/User.js");

//Get all users
router.get("/", async (req, res) => {
  try {

    const users = await User.find();
    console.log(users);
    res.status(200).json({ success: true, data: users });
  } catch (e) {
    res.status(404).json({ success: false, error: err.message });
  }
});

// Add user
router.post("/", async (req, res) => {
  try{
    console.log(req.body)
      const user = await User.create({ name: req.body.name, email: req.body.email, pwd: req.body.pwd })
    res.status(201).json({
      success: true,
      dbid: user._id
    });
  } catch (err) {
    console.log(err);
    res.status(400).json({ success: false, error: err.message });
  }
});


module.exports = router;
